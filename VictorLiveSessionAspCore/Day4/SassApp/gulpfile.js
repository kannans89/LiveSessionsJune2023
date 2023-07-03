var gulp = require("gulp");
var concat = require("gulp-concat");
var uglify = require("gulp-uglify");
var sass = require("gulp-sass")(require("sass"));
var cssmin = require("gulp-cssmin");
var paths = {
  webroot: "./wwwroot/",
  nodeModules: "./node_modules/",
};

paths.sassFiles = "./Styles/*.scss";
paths.compiledCssFileName = "main.min.css";
paths.destinationCssFolder = paths.webroot + "css/";

gulp.task("min:scss", function () {
  return gulp
    .src(paths.sassFiles)
    .pipe(sass().on("error", sass.logError))
    .pipe(concat(paths.compiledCssFileName))
    .pipe(cssmin())
    .pipe(gulp.dest(paths.destinationCssFolder));
});

gulp.task("sass:watcher", function () {
  gulp.watch("./Styles/*.scss", gulp.series("min:scss"));
});
