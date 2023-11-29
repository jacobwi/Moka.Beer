const gulp = require('gulp');
const cleanCSS = require('gulp-clean-css');

// Task to minify and move CSS
gulp.task('styles', () =>
    gulp.src('node_modules/beercss/dist/cdn/*.css')
        .pipe(cleanCSS({compatibility: 'ie8'}))

        .pipe(gulp.dest('wwwroot/css')));

// Default task
gulp.task('default', gulp.series('styles'));
