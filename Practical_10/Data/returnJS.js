var text = document.getElementById("text");

document.getElementById("Buttons").addEventListener("click", (e) => {
	switch (e.target.id) {
		case "PRINT":
			text.classList.add("Display");
			text.classList.remove("Hide");
			break;
		case "BOLD":
			text.classList.add("Bold");
			break;
		case "ITALIC":
			text.classList.add("Italic");
			break;
		case "UNDERLINE":
			text.classList.add("Underline");
			break;
		case "RESET":
			text.classList.remove("Bold");
			text.classList.remove("Italic");
			text.classList.remove("Underline");
			break;
		default:
			console.log("wrong option!");
			break;
	}
});