import React, { useState, useEffect} from "react";

function Header({ listData, setList, filteredList, setFilteredList}) {
  const defaultList = { text: "", completed: false };
  const [listItem, setListItem] = useState(defaultList);
  const onChangeInput = (e) => {
    setListItem({ ...listItem, text: e.target.value });
  };

  const onSubmit = (e) => {
    e.preventDefault();
    if (listItem.text === "") return false;
    setList([...listData, listItem]);
    setListItem(defaultList);
    setFilteredList([...listData, listItem])
  };

 

  return (
    <header className="header">
      <h1>todos</h1>
      <form onSubmit={onSubmit}>
        <input
          type="text"
          className="new-todo"
          placeholder="What needs to be done?"
          value={listItem.text}
          onChange={onChangeInput}
          autoFocus
        />
      </form>
    </header>
  );
}

export default Header;
