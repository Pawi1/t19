import './Offer.css';

function Offer(props) {
  return (
    <div className="Offer">
      <h3>Marka: {props.brand}</h3>
      <h5>Zdjęcie:</h5>
      <div className="image">
        <img src={props.img} alt={props.img}/>
      </div>
    </div>
  );
}
export default Offer;
