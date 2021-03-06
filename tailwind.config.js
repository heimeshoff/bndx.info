module.exports = {
  purge: [
    './src/**/*.html',
    './src/**/*.js',
  ],
  darkMode: false,
  theme: {
    extend: {
      fontFamily: {
        sans: [ 'Unica One', 'Roboto'],
        serif: [ 'Crimson Text' ],
      }
    },
  },
  variants: {
    extend: {
      backgroundColor: [ 'hover', 'focus', 'group-hover'],
      borderWidth: ['hover', 'focus'],
      translate: ['hover', 'group-hover'],
    },
  },
  plugins: [],
}