'use strict';
module.exports = function (grunt) {
  // load all grunt tasks
  grunt.loadNpmTasks('grunt-contrib-less');
  grunt.loadNpmTasks('grunt-contrib-watch');
  grunt.loadNpmTasks('grunt-contrib-uglify');
  grunt.initConfig({
    watch: {
      // if any .less file changes in directory "build/less/" run the "less"-task.
        files: ["Admin/build/less/*.less", "Admin/build/less/skins/*.less", "Admin/dist/js/app.js"],
      tasks: ["less", "uglify"]
    },
    // "less"-task configuration
    //this task will compile all less files upon saving to create both AdminLTE.css and AdminLTE.min.css
    less: {
      //Development not compressed
      development: {
        options: {
          //Wether to compress or not
          compress: false
        },
        files: {
          // compilation.css  :  source.less
            "Admin/dist/css/AdminLTE.css": "Admin/build/less/AdminLTE.less",
            "Admin/dist/css/skins/skin-blue.css": "Admin/build/less/skins/skin-blue.less",
            "Admin/dist/css/skins/skin-black.css": "Admin/build/less/skins/skin-black.less",
            "Admin/dist/css/skins/skin-yellow.css": "Admin/build/less/skins/skin-yellow.less",
            "Admin/dist/css/skins/skin-green.css": "Admin/build/less/skins/skin-green.less",
            "Admin/dist/css/skins/skin-red.css": "Admin/build/less/skins/skin-red.less",
            "Admin/dist/css/skins/skin-purple.css": "Admin/build/less/skins/skin-purple.less",
            "Admin/dist/css/skins/_all-skins.css": "Admin/build/less/skins/_all-skins.less"
        }
      },
      //production compresses version
      production: {
        options: {
          //Wether to compress or not          
          compress: true
        },
        files: {
          // compilation.css  :  source.less
            "Admin/dist/css/AdminLTE.min.css": "Admin/build/less/AdminLTE.less",
            "Admin/dist/css/skins/skin-blue.min.css": "Admin/build/less/skins/skin-blue.less",
            "Admin/dist/css/skins/skin-black.min.css": "Admin/build/less/skins/skin-black.less",
            "Admin/dist/css/skins/skin-yellow.min.css": "Admin/build/less/skins/skin-yellow.less",
            "Admin/dist/css/skins/skin-green.min.css": "Admin/build/less/skins/skin-green.less",
            "Admin/dist/css/skins/skin-red.min.css": "Admin/build/less/skins/skin-red.less",
            "Admin/dist/css/skins/skin-purple.min.css": "Admin/build/less/skins/skin-purple.less",
            "Admin/dist/css/skins/_all-skins.min.css": "Admin/build/less/skins/_all-skins.less"
        }
      }
    },
    //Uglify task info. Compress the js files.
    uglify: {
      options: {
        mangle: true,
        preserveComments: 'some'
      },
      my_target: {
        files: {
            'Admin/dist/js/app.min.js': ['Admin/dist/js/app.js']
        }
      }
    }
  });
  // the default task (running "grunt" in console) is "watch"
  grunt.registerTask('default', ['watch']);
};