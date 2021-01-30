const path = require('path')
const MiniCSSExtractPlugin = require("mini-css-extract-plugin");

module.exports =  function (evn, argv) {
  var mode = argv.mode || "development";
  var isProduction = mode === "production";
  console.log("Webpack mode: " + mode);

  return {
    entry: "./src/App.fs.js",
    mode: mode,
    output: {
      path: path.join(__dirname, "./public"),
      filename: "bundle.js",
    },
    devServer: {
        contentBase: "./public",
        port: 8080,
        historyApiFallback: {
          index: 'index.html'
        },        
    },
    module: {
        rules: [
          {
            test: /\.css$/,
            use: 
              [
                MiniCSSExtractPlugin.loader,
                'css-loader',
                'postcss-loader',
              ],
          }
        ]
    },
    plugins: [
      new MiniCSSExtractPlugin ({ 
        linkType: 'text/css',
        filename: 'style.css'
      }),
    ], 
  }
}