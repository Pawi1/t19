import './Header.css';

function Header(props) {
  return (
    <div className="Header">
      <h1>Witamy na stronie {props.companyName}</h1>
      <img src='img/logo.png' />
    </div>
  );
}
export default Header;
