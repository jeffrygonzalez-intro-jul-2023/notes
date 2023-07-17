## Web Page
[Tailwind CSS - Rapidly build modern websites without ever leaving your HTML.](https://tailwindcss.com/)
[Install Tailwind CSS with Angular - Tailwind CSS](https://tailwindcss.com/docs/guides/angular)


## How to Install in Angular
			- ` npm install -D tailwindcss postcss autoprefixer @tailwindcss/forms @tailwindcss/typography daisyui  `
			- `npx tailwindcss init`


## Tailwind Config

```js
/** @type {import('tailwindcss').Config} */

module.exports = {

  content: [

    "./src/**/*.{html,ts}",

  ],

  theme: {

    extend: {},

  },

  plugins: [

    require('@tailwindcss/forms'),

    require('@tailwindcss/typography'),

    require('daisyui')

  ],

  daisyui: {

    themes: ["aqua", "cupcake", "cyberpunk"]

  }

}
```
