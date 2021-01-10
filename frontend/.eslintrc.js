module.exports = {
  root: true,
  parserOptions: {
      parser: "babel-eslint"
  },
  env: {
      browser: true
  },
  extends: [
      // https://github.com/vuejs/eslint-plugin-vue#priority-a-essential-error-prevention
      // consider switching to `plugin:vue/strongly-recommended` or `plugin:vue/recommended` for stricter rules.
      "plugin:vue/strongly-recommended",
      // https://github.com/standard/standard/blob/master/docs/RULES-en.md
      "standard"
  ],
  // required to lint *.vue files
  plugins: ["vue"],
  // add your custom rules here
  rules: {
      "no-extend-native": ["error", { exceptions: ["Array"] }],
      // allow async-await
      "generator-star-spacing": "off",
      // allow debugger during development
      "no-debugger": process.env.NODE_ENV === "production" ? "error" : "off",
      "vue/max-attributes-per-line": ["error", {
          singleline: 2,
          multiline: {
              max: 2,
              allowFirstLine: false
          }
      }],
      "vue/html-closing-bracket-newline": ["error", {
          singleline: "never",
          multiline: "never"
      }],
      "vue/html-indent": ["error", 4],
      indent: ["error", 4, {
          FunctionDeclaration: {
              parameters: "first"
          }
      }],
      "padded-blocks": ["off", "always"],
      "padding-line-between-statements": ["error",
          { blankLine: "always", prev: "multiline-block-like", next: "*" },
          { blankLine: "always", prev: "*", next: "return" },
          { blankLine: "always", prev: "singleline-const", next: "*" },
          { blankLine: "never", prev: "singleline-const", next: "singleline-const" },
          { blankLine: "always", prev: "import", next: "*" },
          { blankLine: "never", prev: "import", next: "import" },
          { blankLine: "any", prev: "function", next: "*" }
      ],
      quotes: ["error", "double", {
          avoidEscape: true,
          allowTemplateLiterals: true
      }],
      "dot-notation": "off",
      "no-tabs": "off",
      "no-unreachable": "error",
      semi: ["error", "always"],
      "operator-linebreak": ["error", "before", {
          overrides: { "=": "none" }
      }],
      "eol-last": "off"
  }
};
