import { createContext, useState, useContext, useEffect } from "react";
import CityData from "../city.json";
import axios from "axios";
const WeatherContext = createContext();
export const WeatherProvider = ({ children }) => {
  const url = "https://api.openweathermap.org/data/2.5/onecall?";
  const apiKey = "8b64c40e604d3a0718eb6e31f0bf60d1";
  const [city, setCity] = useState(1);
  const [cityDetail, setCityDetail] = useState();
  const getCity = CityData.find((item, index) => item.id === (cityDetail === undefined ? 1 : city));
  
  useEffect(() => {
     axios
      .get(
        `${url}lat=${getCity.latitude}&lon=${getCity.longitude}&exclude=current,minutely,hourly,alerts&appid=${apiKey}&&units=metric`
      )
      .then((response) => setCityDetail(response.data));
  }, [getCity]);
  
  console.log(cityDetail);
  const values = {
    city,
    setCity,
    cityDetail,
    CityData,
    getCity
  };

  return (
    <WeatherContext.Provider value={values}>{children}</WeatherContext.Provider>
  );
};

export const useWeather = () => useContext(WeatherContext);
