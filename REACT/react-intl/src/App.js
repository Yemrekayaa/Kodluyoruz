import './App.css';

import {IntlProvider, FormattedMessage} from 'react-intl'
import { useEffect, useState } from 'react';


const messages = {
  'tr-TR':{
    title: "Merhaba Dünya!",
    description: "{count} yeni mesajınız var!"
  },
  'en-US':{
    title: "Hello World!",
    description: "You have {count} new messages!"
  }
}


function App() {
  const defaultLocale = localStorage.getItem('locale') || navigator.language;
  const [locale, setLocale] = useState(defaultLocale);
  
  useEffect(() => {
    localStorage.setItem('locale',locale);
  }, [locale])

  return (
    
    <div className="App">
      <IntlProvider messages={messages[locale]} locale={locale}>
      <FormattedMessage id="title" />
      <p><FormattedMessage id="description" values={{count:3}}/></p>
         <br/> <br />
         <button onClick={()=> setLocale("tr-TR")}>TR</button>
         <button onClick={()=> setLocale("en-US")}>EN</button>
      </IntlProvider>
      
    </div>
  );
}

export default App;
