module.exports = {
  purge: [
    './src/**/*.html',
    './src/**/*.js',
  ],
  darkMode: false,
  theme: {
    extend: {
      fontFamily: {
        sans: [ 'Crimson Text', 'Roboto'],
        serif: [ 'Unica One' ],
      }
    },
  },
  variants: {
    extend: {
      borderWidth: ['hover', 'focus'],
    },
  },
  plugins: [],
}