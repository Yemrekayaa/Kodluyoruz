import React from 'react'
import { useWeather } from '../context/weatherContext'
import Weather from './weather';
import SelectCity from './selectCity';
function Main() {
    const getWeather = useWeather();
  return (
      
    <>  
        <Weather>
            <SelectCity/>
        </Weather>       
    </>

  )
}

export default Main