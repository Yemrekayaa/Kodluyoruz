import React from "react";

function ToggleAll({ listData, setList }) {
    const toggleAllItem = () =>{
        const tg = document.querySelector('.toggle-all') ;
        listData = listData.map((item,index)=>{
            return {text:item.text, completed:!tg.checked};
        });
        setList([...listData]);
        tg.checked = !tg.checked;
    };

  return (
    <>
      <input className="toggle-all" type="checkbox" />
      <label htmlFor="toggle-all"  onClick={toggleAllItem}>Mark all as complete</label>
    </>
  );
}

export default ToggleAll;
