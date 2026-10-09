import './App.css';
import Footer from './components/footer/Footer';
import Header from './components/header/Header';

export default function App(props) {
  return (
    <div className="App">
      <Header dealershipName="Autokomis Lech Lewandowski" />
    
      <Footer open="10:00" close="18:00" />
    </div>
  );
}
