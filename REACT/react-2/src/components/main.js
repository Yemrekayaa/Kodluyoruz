import React, { useEffect, useState } from "react";
import Header from "./header.js";
import Todolist from "./todolist.js";
import Footer from './footer'
import ToggleAll from './toggleAll.js';

function Main() {
  const denemelik = [
    {
      text: "Ali ata bak",
      completed: false,
    },
    {
      text: "Ali ata bak2",
      completed: true,
    },
    {
      text: "Ali ata bak3",
      completed: false,
    },
  ];

  const [listData, setList] = useState(denemelik);
  const [filteredList, setFilteredList]=useState(listData);
  
  
  return (
    <>
      <Header listData={listData} setList={setList} filteredList={filteredList} setFilteredList={setFilteredList}/>

      <section className="main">
        <ToggleAll listData={listData} setList={setList}/>
        <Todolist listData={listData} setList={setList} />
      </section>

     <Footer listData={listData} setList={setList} filteredList={filteredList} setFilteredList={setFilteredList}/> 
    </>
  );
}

export default Main;
