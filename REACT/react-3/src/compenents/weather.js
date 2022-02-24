import React, { useEffect, useState } from "react";
import { useWeather } from "../context/weatherContext";

function Weather({ children }) {
  const getWeather = useWeather();
  const [dailyWeather, setdailyWeather] = useState([{}]);
  
  useEffect(() => {

    setTimeout(() => {const data = getWeather.cityDetail.daily.map((item, index) => {
        return {
          icon: item.weather[0].icon,
          max: parseInt(item.temp.max),
          min: parseInt(item.temp.min),
          desc: item.weather[0].description,
          day: item.dt,
        };
      });
    setdailyWeather(data);},0)
    
    
  }, [getWeather.cityDetail]);

  return (
    <div className="weather">
      <ul>
        {children}
        {dailyWeather.map((item, index) => (
          <li key={index}>
            <div className={`${index === 0 && "current"}`}>
              <div className="text small-large">{getDate(item.day)}</div>
              <div className="text small-text">{item.desc}</div>
              <img
                className="image"
                src={`http://openweathermap.org/img/wn/${item.icon}@2x.png`}
                alt={item.desc}
              />
              <div className="text large-text">
                <span>{item.max}&#176;</span> /
                <span className="min">{item.min}&#176;</span>
              </div>
            </div>
          </li>
        ))}
      </ul>
    </div>
  );
}

function getDate(unix) {
  var theDate = new Date(unix * 1000).toString().substring(0, 3);
  return theDate;
}
export default Weather;
