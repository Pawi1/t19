import './Header.css';

export default function Header(props) {
  return (
    <header>
      <h1>Witamy na stronie firmy: {props.dealershipName}</h1>
      <img src='img/logo.png' alt='logotyp firmy' className='logo'/>
    </header>
  );
}
