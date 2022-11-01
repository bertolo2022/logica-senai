<?php
/**
$alunos = [
    'Andre' => 10,
    'Maria' => 10,
    'Sebastiao' => 10,
	'José' => 10,
	'Juçara' => 10
];
foreach ($aluno as $alunos => $media) {
	
    echo $alunos;
}
**/


$alunos = [
    'aluno-1' => 10,
    'aluno-2' => 9,
    'aluno-3' => 8,
    'aluno-4' => 7,
	'aluno-5' => 9
];
$soma = 0;
$i = 0;
foreach ($alunos as $aluno => $notas) {
    echo "<br>". $aluno." nota = ".$notas;

	echo "<br>";
	$soma += $notas;
}

$media = $soma / 5;
echo $media;


