import './App.css';
import Footer from './components/footer/Footer';
import Header from './components/header/Header';
import Main from './components/main/Main';
import cars from "./cars.json";
export default function App(props) {
  return (
    <div className="App">
      <Header dealershipName="Autokomis Lech Lewandowski" logo="img/logo.png"/>
      <Main cars={cars}/>
      <Footer open="10:00" close="18:00" />
    </div>
  );
}
