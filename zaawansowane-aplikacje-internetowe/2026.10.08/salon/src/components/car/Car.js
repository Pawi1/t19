import "./Car.css";
export default function Car(props) {
  return (
    <div className="car">
      <p>{props.carName}</p>
      <img src={props.img} alt={props.img}/>
    </div>
  );
}
