export default function Shoe({shoe}){
  return(
  <div className='shoe'>
    <div className='img' style={{ backgroundImage: `url(${shoe.img})` }}></div>
    <div className='info'>
      <h3>Rodzaj: {shoe.name}</h3>
      <p>Stan magazynu: {shoe.quantity}</p>
      <div className='btn'>
        <button type="button" onClick={() => window.onRetailSale(shoe)}>Sprzedaż detaliczna</button>
        <button type="button" onClick={() => window.addToStockPrompt(shoe)}>Przyjęcie tych butów</button>
      </div>
    </div>
  </div>
  );
}