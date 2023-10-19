/// <reference path="../types/index.d.ts" />

class LoadingScene extends Phaser.Scene {
  constructor(name) {
    super(name);
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
    for (let i = 0; i < 1000; i++) {
      this.load.image("pet" + i, "assets/pet.png");
    }
    const bg = this.add.rectangle(
      0,
      0,
      this.sys.game.config.width,
      this.sys.game.config.height,
      0xffffff
    );
    bg.setOrigin(0, 0);
    const loadingBar = this.add.rectangle(0, 0, 200, 40, 0x000000, 0.1);
    Phaser.Display.Align.In.Center(loadingBar, bg);
    const loadingLine = this.add.rectangle(0, 0, 0, 40, 0x50f31f);
    Phaser.Display.Align.In.LeftCenter(loadingLine, loadingBar);
    this.load.on("progress", (percentage) => {
      loadingLine.setSize(percentage * 200, loadingLine.height);
      Phaser.Display.Align.In.LeftCenter(loadingLine, loadingBar);
    });
  }
  create() {
    this.scene.start("home");
  }
}
