import "./Main.css";
import Column from "../column/Column";
export default function Main(props) {
  return (
  <main>
    {props.cars.map(col =>
      (
        <Column kind={col.kind} cars={col.cars} />
      ))}
  </main>
  );
}
