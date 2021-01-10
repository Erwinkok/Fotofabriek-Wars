module.exports = {
    lintOnSave: true,

    devServer: {
        watchContentBase: false
    },

    chainWebpack: config => {
        config.module.rule("ts");
        config.module.rule("ts").use("ts-loader");
        config.module.rule("ts").use("babel-loader");
        config.module.rule("ts").use("cache-loader");
        config.plugin("fork-ts-checker");
    }
};