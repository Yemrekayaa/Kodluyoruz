import React from "react";
import { useWeather } from "../context/weatherContext";

function SelectCity() {
  const getWeather = useWeather();

  const [value, setValue] = React.useState(1);

  const handleChange = (event) => {
    setValue(event.target.value);
    getWeather.setCity(parseInt(value))
  };

  console.log(value);
  return (
    <div className="selectCity">
      <select value={value} onChange={handleChange}>
        {getWeather.CityData.map((item, index) => {
          return (
            <option key={item.id} value={item.id}>
              {item.name}
            </option>
          );
        })}
      </select>
    </div>
  );
}

export default SelectCity;
