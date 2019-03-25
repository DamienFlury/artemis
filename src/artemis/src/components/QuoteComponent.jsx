import React, { useState } from 'react';
import { Typography } from '@material-ui/core';

const quotes = [
  { quote: "Don't cry because it's over, smile because it happened.", author: 'Dr. Seuss' },
  { quote: "Be who you are and say what you feel, because those who mind don't matter, and those who matter don't mind.", author: 'Bernard M. Baruch' },
  { quote: 'Those who dare to fail miserably can achieve greatly.', author: 'John F. Kennedy' },
  { quote: 'It is hard to fail, but it is worse never to have tried to succeed.', author: 'Theodore Roosevelt' },
  { quote: 'A friend is someone who knows all about you and still loves you.', author: 'Elbert Hubbart' },
];

const fonts = [
  'Shadows Into Light', 'Amatic SC', 'Dancing Script', 'Gloria Hallelujah', 'Indie Flower', 'Satisfy', 'Courgette', 'Handlee',
];

const QuoteComponent = () => {
  const [quote] = useState(quotes[Math.floor(Math.random() * quotes.length)]);
  const [font] = useState(fonts[Math.floor(Math.random() * fonts.length)]);

  return (
    <div style={{ padding: 20, margin: '20px auto' }}>
      <Typography
        style={{ fontSize: '3rem', fontFamily: `${font}, cursive` }}
      >
      &laquo;
        {' '}
        {quote.quote}
        {' '}
      &raquo;
      </Typography>
      <Typography>
        {' '}
-
        {' '}
        {quote.author}
      </Typography>
    </div>
  );
};

export default QuoteComponent;
