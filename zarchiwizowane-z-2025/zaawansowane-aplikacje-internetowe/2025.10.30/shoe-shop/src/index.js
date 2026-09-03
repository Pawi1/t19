import React from "react";
import ReactDOM from "react-dom/client";
import "./index.css";
import Header from "./components/Header/Header.jsx"
import Footer from "./components/Footer/Footer.jsx"
import Main from "./components/Main/Main.jsx"

const root = ReactDOM.createRoot(document.getElementById("root"));
root.render(
  <React.StrictMode>
  <Header siteName="Mojżesz"/>
  <Main/>
  <Footer/>
  </React.StrictMode>
);
