/// <reference path="./types/index.d.ts" />

const loadingScene = new LoadingScene("loading");
const homeScene = new HomeScene("home");
const gameScene = new MainScene("Jatek");

const game = new Phaser.Game({
  width: 360,
  height: 640,
  scene: [loadingScene, homeScene, gameScene],
});