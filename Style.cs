* {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
}

body {
    font-family: Arial, sans-serif;
    display: flex;
    justify-content: center;
    align-items: center;
    min-height: 100vh;
    background-color: #f0f0f0;
}

.calculator {
    background-color: #333;
    border-radius: 10px;
    padding: 20px;
    box-shadow: 0 5px 15px rgba(0, 0, 0, 0.3);
}

#display {
    width: 100%;
    height: 60px;
    margin-bottom: 20px;
    text-align: right;
    font-size: 24px;
    color: white;
    background-color: #222;
    border: none;
    border-radius: 5px;
    padding: 10px;
}

.buttons {
    display: grid;
    grid-template-columns: repeat(4, 1fr);
    gap: 10px;
}

button {
    height: 50px;
    font-size: 18px;
    border: none;
    border-radius: 5px;
    cursor: pointer;
    transition: background-color 0.2s;
}

button:hover {
    opacity: 0.9;
}

button:active {
    transform: scale(0.95);
}

.number, .decimal {
    background-color: #555;
    color: white;
}

.operator {
    background-color: #ff9500;
    color: white;
}

.equals {
    background-color: #28a745;
    color: white;
    grid-column: span 1;
}

.clear, .delete {
    background-color: #dc3545;
    color: white;
}
