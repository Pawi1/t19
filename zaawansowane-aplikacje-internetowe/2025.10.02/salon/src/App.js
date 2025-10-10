import './App.css';
import Header from './components/Header/Header.js';
import Content from './components/Content/Content.js';
import Footer from './components/Footer/Footer.js';

function App() {
  return (
    <div className="App">
      <Header companyName='AutoCar'/>
      <Content />
      <Footer openingHours='8:00' closingHours='22:00'/>
    </div>
  );
}
export default App;
