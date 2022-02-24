import './App.css';
import { WeatherProvider } from './context/weatherContext';
import Main from './compenents/main';

function App() {
  console.log("App Tekrarlandı");
  return (
    <div className="App">
      <WeatherProvider>
        <Main/>
      </WeatherProvider>
    </div>
  );
}

export default App;
