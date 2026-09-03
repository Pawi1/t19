import './Content.css';
import Offer from './Offer/Offer';
import OfferTitle from './OfferTitle/OfferTitle';

function Content() {
  return (
    <div className="Content">
    <div>
      <OfferTitle kind='nowe' />
      <Offer brand='Audi' img='img/cars/audi-a8.jpg'/>
      <Offer brand='BMW' img='img/cars/bmw-m3.jpg'/>
      <Offer brand='Škoda' img='img/cars/skoda-fabia.jpg'/>
    </div>
    <div>
      <OfferTitle kind='kultowe' />
      <Offer brand='Audi' img='img/cars/audi-200.jpg'/>
      <Offer brand='BMW' img='img/cars/bmw-e32.jpg'/>
      <Offer brand='Škoda' img='img/cars/skoda-favorit.jpg'/>
    </div>
    </div>
  );
}
export default Content;
