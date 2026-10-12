import Car from "../car/Car";
export default function Column(props) {
  return (
    <div className="column">
      <p>Polecamy {props.kind} samochody w najlepszej cenie</p>
      <div>
        {props.cars.map(car => 
          (
              <Car carName={car.carName} img={car.img} />
          ))}
        </div>
    </div>
  );
}
