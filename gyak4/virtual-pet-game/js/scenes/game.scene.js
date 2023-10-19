/// <reference path="../types/index.d.ts" />

class MainScene extends Phaser.Scene {
  constructor(name) {
    super(name);
  }
  init() {
    this.stats = {
      health: 100,
      healthDecay: -3,
      fun: 100,
      funDecay: -8,
    };
    this.selectedItem = null;

    this.uiBlocked = false;
  }

  create() {
    this.createUI();

    this.statsDecayEvent = this.time.addEvent({
      delay: 1000,
      repeat: -1,
      callback: () => {
        this.updateStats({
          health: this.stats.healthDecay,
          fun: this.stats.funDecay,
        });
      },
    });
  }
  createUI() {
    this.bg = this.add.sprite(0, 0, "bg").setInteractive();
    this.bg.setOrigin(0, 0);
    this.bg.on("pointerdown", (pointer) => this.placeItem(pointer));

    this.pet = this.add.sprite(180, 380, "pet", 0);
    this.pet.setDepth(1);
    this.pet.setInteractive({ cursor: "grab" });
    this.pet.setData("speed", 0.5);
    this.anims.create({
      key: "eat",
      duration: 500,
      frames: this.anims.generateFrameNames("pet", {
        frames: [1, 2, 3],
      }),
      frameRate: 7,
      yoyo: true,
    });
    this.input.setDraggable(this.pet);
    this.input.on("drag", (pointer, gameObject, dragX, dragY) => {
      gameObject.x = dragX;
      gameObject.y = dragY;
    });

    this.candyBtn = this.add
      .sprite(72, 550, "candy")
      .setInteractive({ cursor: "pointer" });
    this.candyBtn.setData("stats", { health: -20, fun: 10 });
    this.candyBtn.on("pointerdown", () => this.pickItem(this.candyBtn));

    this.duckBtn = this.add
      .sprite(144, 550, "duck")
      .setInteractive({ cursor: "pointer" });
    this.duckBtn.setData("stats", { health: -5, fun: 5 });
    this.duckBtn.on("pointerdown", () => this.pickItem(this.duckBtn));

    this.appleBtn = this.add
      .sprite(216, 550, "apple")
      .setInteractive({ cursor: "pointer" });
    this.appleBtn.setData("stats", { health: 20, fun: -3 });
    this.appleBtn.on("pointerdown", () => this.pickItem(this.appleBtn));

    this.rotateBtn = this.add
      .sprite(288, 550, "rotate")
      .setInteractive({ cursor: "pointer" });
    this.rotateBtn.setData("stats", { health: -30, fun: 40 });
    this.rotateBtn.on("pointerdown", () => this.rotatePet(this.rotateBtn));
    this.healthText = this.add.text(20, 20, `Health:${this.stats.health}`, {
      font: "24px Arial",
    });
    this.funText = this.add.text(20, 40, `Fun:${this.stats.fun}`, {
      font: "24px Arial",
    });
  }

  resetUI() {
    this.selectedItem = null;
    this.candyBtn.alpha = 1;
    this.duckBtn.alpha = 1;
    this.appleBtn.alpha = 1;
    this.rotateBtn.alpha = 1;
  }

  pickItem(item) {
    if (this.uiBlocked) {
      return;
    }
    this.resetUI();
    this.selectedItem = item;
    item.alpha = 0.5;
  }
  placeItem(pointer) {
    if (!this.selectedItem || this.uiBlocked) {
      return;
    }
    this.uiBlocked = true;

    const newItem = this.add.sprite(
      pointer.worldX,
      pointer.worldY,
      this.selectedItem.texture.key
    );
    this.tweens.add({
      targets: this.pet,
      duration:
        Phaser.Math.Distance.Between(
          this.pet.x,
          this.pet.y,
          newItem.x,
          newItem.y
        ) / this.pet.data.values.speed,
      x: newItem.x,
      y: newItem.y,
      onComplete: () => {
        this.updateStats(this.selectedItem.data.values.stats);
        this.pet.on(Phaser.Animations.Events.ANIMATION_COMPLETE, () => {
          this.uiBlocked = false;
          this.resetUI();
          newItem.destroy();
        });
        this.pet.play("eat");
      },
    });
  }
  rotatePet(item) {
    if (this.uiBlocked) {
      return;
    }

    this.resetUI();
    this.rotateBtn.alpha = 0.5;
    this.uiBlocked = true;
    this.tweens.add({
      targets: this.pet,
      duration: 600,
      angle: 360,
      onComplete: () => {
        this.updateStats(this.rotateBtn.data.values.stats);
        this.resetUI();
        this.uiBlocked = false;
      },
    });
  }
  updateStats(stats) {
    this.stats.health += stats.health;
    this.stats.fun += stats.fun;
    if (this.stats.health <= 0 || this.stats.fun <= 0) {
      this.stats.health = 0;
      this.stats.fun = 0;
      this.gameOver();
    }
    this.healthText.text = `Health:${this.stats.health}`;
    this.funText.text = `Fun:${this.stats.fun}`;
  }
  gameOver() {
    this.resetUI();
    this.uiBlocked = true;
    this.pet.setFrame(4);
    this.statsDecayEvent.destroy();
    this.time.addEvent({
      delay: 2000,
      repeat: 0,
      callback: () => {
        this.scene.start("loading");
      },
    });
  }
}
