/*
This file in the main entry point for defining Gulp tasks and using Gulp plugins.
Click here to learn more. http://go.microsoft.com/fwlink/?LinkId=518007
*/

var gulp = require('gulp'),
    autoprefixer = require("gulp-autoprefixer"),
    rename = require("gulp-rename"),
    uglify = require("gulp-uglify"),
    cleanCss = require("gulp-clean-css"),
    concat = require("gulp-concat"),
    browsersync = require("browser-sync").create();

gulp.task("compileCss", function () {
    gulp.src([
        "Content/libs/bootstrap/dist/css/bootstrap.css",
        "Content/libs/font-awesome/css/font-awesome.css",
        "Content/libs/izitoast/dist/css/iziToast.css",
        "Content/style/**/*.css"
    ])
    .pipe(concat("style.css"))
    .pipe(autoprefixer())
    .pipe(gulp.dest("Content/dist"))
    .pipe(browsersync.stream())
    .pipe(rename({ suffix: ".min" }))
    .pipe(cleanCss())
    .pipe(gulp.dest("Content/dist"))
    .pipe(browsersync.stream());
});

gulp.task("compileJs", function () {
    gulp.src([
        "Content/libs/jquery/dist/jquery.js",
        "Content/libs/bootstrap/dist/js/bootstrap.js",
        "Content/libs/izitoast/dist/js/iziToast.js",
        "Content/scripts/**/*.js"
    ])
    .pipe(concat("script.js"))
    .pipe(gulp.dest("Content/dist"))
    .pipe(browsersync.stream())
    .pipe(rename({ suffix: ".min" }))
    .pipe(uglify())
    .pipe(gulp.dest("Content/dist"))
    .pipe(browsersync.stream());
});

gulp.task("browserSync", function () {
    browsersync.init({
        proxy: "http://localhost:18340/" //Skift til port i Visual studio server!
    })
});

gulp.task("watch",["browserSync","compileCss","compileJs"], function () {
    gulp.watch("**/*.{html,htm,cshtml}", browsersync.reload);
    gulp.watch(["Content/style/**/*.css","Content/style/*.css"], ["compileCss"]);
    gulp.watch(["Content/script/**/*.js","Content/script/*.js"], ["compileJs"]);
})

gulp.task('default', function () {
    // place code for your default task here
});