
function Footer({ listData, setList, filteredList, setFilteredList}) {

    const clearAll = () =>{
        setList([]);
    };

    const filteredList2 = (e,a) =>{
        if(a === 'all' && e.target.className !== 'selected'){
            setList(filteredList);
            setFilteredList(listData);
            e.target.className = 'selected';
            document.querySelector("#active").className = "";
            document.querySelector("#completed").className = "";
            console.log(listData);
        }else if(a === 'active' && e.target.className !== 'selected'){     
            const deneme = filteredList.filter((item)=>item.completed === false);
            setList(deneme);
            e.target.className = 'selected'
            document.querySelector("#all").className = "";
            document.querySelector("#completed").className = "";
            console.log(listData);
        }else if(a === 'completed' && e.target.className !== 'selected'){     
            const deneme = filteredList.filter((item)=>item.completed === true);
            setList(deneme);
            e.target.className = 'selected'
            document.querySelector("#all").className = "";
            document.querySelector("#active").className = "";
            console.log(listData);
        }
    };
  return (
    
	<footer className="footer">	
		<span className="todo-count">
			<strong>{listData.length} </strong>
			items left
		</span>

		<ul className="filters">
			<li>
				<a id="all" className="selected" onClick={(e)=>{filteredList2(e,'all')}}>All</a>
			</li>
			<li>
				<a id="active" onClick={(e)=>{filteredList2(e,'active')}}>Active</a>
			</li>
			<li>
				<a id="completed" onClick={(e)=>{filteredList2(e,'completed')}}>Completed</a>
			</li>
		</ul>

		
		<button className="clear-completed" onClick={clearAll}>
			Clear completed
		</button>

        
	</footer>



  )
}

export default Footer