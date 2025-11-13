import './Shoe.css'

export default function Shoe({ shoe, onRetailSale, onAddToStock }){
  return(
  <div class='shoe'>
    <div class='img' style={{ backgroundImage: `url(${shoe.img})` }}></div>
    <div class='info'>
      <h3>Rodzaj: {shoe.name}</h3>
      <p>Stan magazynu: {shoe.quantity}</p>
      <div class='btn'>
        <button type="button" onClick={onRetailSale}>Sprzedaż detaliczna</button>
        <button type="button" onClick={onAddToStock}>Przyjęcie tych butów</button>
      </div>
    </div>
  </div>
  );
}
