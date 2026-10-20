import './App.css';
import Header from './components/Header';
import Footer from './components/Footer';
import Main from './components/Main';
import { useState } from 'react';
import db from './db.json'

const init = db.filter(s => s.isReceivedIntoStock);
export default function App() {
  let [shoes, setShoes] = useState(init);

  window.changeQuantity = (shoe, delta) => {
  setShoes(prev =>
    prev.map(s =>
      s === shoe ? { ...s, quantity: Math.max(0, (s.quantity || 0) + delta) }: s
      )
    );
  }
  window.onRetailSale = (shoe) => {
      window.changeQuantity(shoe,-1);
  }
    
  window.addToStockPrompt = (shoe) => {
    const v = window.prompt('Podaj ilość do dodania');
    if (v === null) return;
    const n = Number(v);
    if (!Number.isFinite(n)) return;
    window.changeQuantity(shoe, n);
  }
  window.shoesFilter = (filterType) => {
     if (filterType === 'isReceivedIntoStock') {
      setShoes(db.filter(s => s.isReceivedIntoStock))
    }
    else if(filterType === 'removeSoldOut') {
      setShoes(prev => prev.filter(s => s.quantity !== 0))
    }
    else {
      setShoes(db.filter(s => s.type === filterType || s.isReceivedIntoStock))
    }
  }
  return (
    <div className="App">
      <Header name='Moje obowie' />
      <Main  shoes={shoes}/>
      <Footer />
    </div>
  );
}
