const path = require('path');
const HtmlWebpackPlugin = require('html-webpack-plugin');
const ESLintPlugin = require('eslint-webpack-plugin');

module.exports = {
    mode: 'production',
    output: {
        path: path.resolve(__dirname, 'build'),
        filename: '[name].[contenthash].js',
        publicPath: '',
    },
    entry: path.resolve(__dirname, './index.tsx'),
    module: {
        rules: [
            {
                test: /\.js$/,
                exclude: /node_modules/,
                use: [{ loader: 'babel-loader' }],
            },
            {
                test: /\.ts(x?)$/i,
                exclude: /node_modules/,
                use: {
                    loader: 'ts-loader',
                    options: {
                        presets: [
                            '@babel/preset-env',
                            '@babel/preset-react',
                            '@babel/preset-typescript',
                        ],
                    },
                },
            },
            {
                test: /\.jpg|\.png$/,
                use: {
                    loader: 'file-loader',
                    options: {
                        outputPath: path.join('..', 'assets'),
                        publicPath: '/assets',
                    },
                },
            },
            {
                test: /\.css$/,
                use: ['style-loader', 'css-loader'],
            },
        ],
    },
    resolve: {
        extensions: ['.tsx', '.ts', '.js'],
    },
    plugins: [
        new HtmlWebpackPlugin({
            template: 'index.html',
        }),
        new ESLintPlugin({
            extensions: ['js', 'jsx', 'ts', 'tsx'],
        }),
    ],
};
