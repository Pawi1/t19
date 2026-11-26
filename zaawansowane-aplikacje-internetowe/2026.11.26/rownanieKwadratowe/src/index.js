import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';
import Header from './components/Header';
import Info from './components/Info';
import Calc from './components/Calc';
import Footer from './components/Footer';

const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(
  <React.StrictMode>
    <div className="App">
      <Header siteName={"Matematyka dla kazdego"} topicName={"Rownania kwadratowe"} />
      <Info />
      <Calc />
      <Footer topicName={"Rownania kwadratowe"} />
    </div>
  </React.StrictMode>
);
