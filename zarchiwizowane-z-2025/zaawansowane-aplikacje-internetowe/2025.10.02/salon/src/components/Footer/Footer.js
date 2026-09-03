import './Footer.css';

function Footer(props) {
  return (
    <p className='Footer'>Zapraszamy codziennie od: {props.openingHours} do: {props.closingHours}</p>
  );
}
export default Footer;
