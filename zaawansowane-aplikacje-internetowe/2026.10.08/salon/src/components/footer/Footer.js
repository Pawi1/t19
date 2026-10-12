import './Footer.css';

export default function Footer(props) {
  return (
    <footer>
      <p>Zapraszamy codziennie od {props.open} do {props.close}</p>
    </footer>
  );
}
