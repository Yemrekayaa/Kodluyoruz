function Todolist({ listData, setList }) {
  const onChangeInput = (e, key) => {
    listData[key].completed = !listData[key].completed;
    setList([...listData]);
  };

  const onClickDelete = (e, key) => {
    listData.splice(key, 1);
    setList([...listData]);
  };

  const editItemChange = (e, key) => {
    listData[key].text= e.target.value;
    setList([...listData]);
  };

  return (
    <ul className="todo-list">
      {listData.map((item, key) => (
        <li key={key} className={item.completed === true ? "completed" : ""}>
          <div className="view">
            <input
              className="toggle"
              type="checkbox"
              onChange={(e) => {
                onChangeInput(e, key);
              }}
              checked={listData[key].completed}
            />
            <label>
              <input
                type="text"
                value={item.text}
                className="edit_item"
               
                onClick={(e) => e.target.readOnly = false}
                onChange={(e) => editItemChange(e,key)}
                readOnly="readonly"
              />
            </label>
            <button
              className="destroy"
              onClick={(e) => {
                onClickDelete(e, key);
              }}
            ></button>
          </div>
        </li>
      ))}
    </ul>
  );
}

export default Todolist;
