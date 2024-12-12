import { useEffect, useState } from "react";
import axios from "axios";
import { useNavigate } from "react-router-dom";

function CadastrarImc() {
    const navigate = useNavigate();
    const [ImcId, SetImcId] = useState("")
    const [Peso, SetPeso] = useState("")
    const [Altura, SetAltura] = useState("")
    const [Resultado, SetResultado] = useState("") 

}

useEffect(() => {
    carregarImc();
}, []);

function carregarImc() {
    fetch("http://localhost:5258/api/imc/listar")
    .then((resposta) => resposta.json())
    .then((ImcId: ImcId[]) => {
        setImcId(imcs)
    });
}


