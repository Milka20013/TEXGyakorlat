/// <reference path="./types/index.d.ts" />

class GameScene extends Phaser.Scene {
  constructor(name) {
    super(name);
  }
  init() {
    this.stats = {
      health: 100,
      fun: 100,
    };
    this.selectedItem = null;

    this.uiBlocked = false;
  }
  preload() {
    this.load.image("apple", "assets/apple.png");
    this.load.image("bg", "assets/backyard.png");
    this.load.image("candy", "assets/candy.png");
    this.load.image("duck", "assets/rubber_duck.png");
    this.load.image("rotate", "assets/rotate.png");
    this.load.spritesheet("pet", "assets/pet.png", {
      frameWidth: 97,
      frameHeight: 83,
      margin: 1,
      spacing: 1,
    });
  }
  create() {
    this.createUI();
  }
  createUI() {
    this.bg = this.add.sprite(0, 0, "bg").setInteractive();
    this.bg.setOrigin(0, 0);
    this.bg.on("pointerdown", (pointer) => this.placeItem(pointer));

    this.pet = this.add.sprite(180, 380, "pet", 0);
    this.pet.setInteractive({ cursor: "grab" });

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
    if (!this.selectedItem) {
      return;
    }
    this.uiBlocked = true;

    const newItem = this.add.sprite(
      pointer.worldX,
      pointer.worldY,
      this.selectedItem.texture.key
    );
    this.updateStats(this.selectedItem.data.values.stats);
    this.uiBlocked = false;
    this.resetUI();
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
    console.log(this.stats);
  }
}

const gameScene = new GameScene("Jatek");

const game = new Phaser.Game({
  width: 360,
  height: 640,
  scene: gameScene,
});
