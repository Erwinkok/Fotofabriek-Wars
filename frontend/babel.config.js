module.exports = {
  presets: [
      "@vue/cli-plugin-babel/preset",
      [
          "@babel/env", {
              modules: false,
              targets: {
                  browsers: [
                      "> 1%",
                      "last 2 versions",
                      "ie >= 10"
                  ]
              }
          }
      ]
  ],
  plugins: [
      "transform-vue-jsx",
      "@babel/transform-runtime"
  ]
};