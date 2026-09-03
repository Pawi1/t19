import "./Footer.css"

const months = ["stycznia","lutego","marca","kwietnia","maja","czerwca","lipca","sierpnia","września","października","listopada","grudnia"];
const days = ["Niedziela","Poniedziałek","Wtorek","Środa","Czwartek","Piątek","Sobota"];
const date = new Date();
export default function Footer(props) {
  return(
    <p>Dzisiaj jest: {days[date.getDay()]} {date.getDate()} {months[date.getMonth()]} {date.getFullYear()} roku</p>
  );
}