import './Offer.css';

function Offer(props) {
  return (
    <div className="Offer">
      <h3>Marka: {props.brand}</h3>
      <h5>Zdjęcie:</h5>
      <img src={props.img} />
    </div>
  );
}
export default Offer;
