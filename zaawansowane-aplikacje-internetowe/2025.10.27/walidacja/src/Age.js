import PropTypes from 'prop-types';

export default function Age(props) {
  console.log('Age:', props.age, 'Months:', props.months); // Dodaj logowanie tutaj
  return (
    <h3>Juz masz {props.age} lat i {props.months} miesiecy</h3>
  );
}

Age.propTypes = {
  age: PropTypes.number.isRequired,
  months: PropTypes.string
};
