import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';
import Age from './Age';

const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(
  <React.StrictMode>
    <Age age="csadas"/>
  </React.StrictMode>
);
