import './Main.css'
import db from './db.json'
import Shoe from './Shoe/Shoe.jsx'
import { useState, useEffect } from 'react'

export default function Main() {
  const [filterType, setFilterType] = useState('isReceivedIntoStock')
  const [shoes, setShoes] = useState(() => db)

  useEffect(() => {
    if (filterType === 'isReceivedIntoStock') {
      setShoes(db.filter(s => s.isReceivedIntoStock))
    }
    else if(filterType === 'removeSoldOut') {
      setShoes(prev => prev.filter(s => s.quantity !== 0))
    }
    else {
      setShoes(db.filter(s => s.type === filterType || s.isReceivedIntoStock))
    }
  }, [filterType])

  function changeQuantity(index, delta) {
    setShoes(prev => prev.map((s, i) => i === index ? { ...s, quantity: Math.max(0, (s.quantity || 0) + delta) } : s));
  }
  
  function retailSale(index) {
    changeQuantity(index, -1);
  }
  
  function addToStockPrompt(index) {
    const v = window.prompt('Podaj ilość do dodania');
    if (v === null) return;
    const n = Number(v);
    if (!Number.isFinite(n)) return;
    changeQuantity(index, n);
  }
  

  return (
    <div>
      <div className="filters">
        <button onClick={() => setFilterType('letnie')}>Przyjmij obuwie letnie</button>
        <button onClick={() => setFilterType('zimowe')}>Przyjmij obuwie zimowe</button>
        <button onClick={() => setFilterType('removeSoldOut')}>Usuń wyprzedane</button>
      </div>

      <div className="list">
        {shoes.map((s, i) => (
          <Shoe
            key={s.name + '_' + i}
            shoe={s}
            onRetailSale={() => retailSale(i)}
            onAddToStock={() => addToStockPrompt(i)}
          />
        ))}
      </div>
    </div>
  )
}
