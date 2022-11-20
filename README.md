# 14tsieberer-Random
Warum braucht man Zufall beim Programmieren?
Zufälle werden beim Programmieren benötigt, um von Benutzer oder Entwickler unabhängig zB. Zahlen zu generieren.

Was ist der Unterschied zwischen Random aus System bzw. aus UnityEngine?
Methoden in UnityEngine.Random sind zwischen 20% und 40% schneller als jene aus System.Random. Ein zweiter Faktor ist, dass UnityEngine.Random eine Statische Klasse ist, deren Status Global geteilt wird, was ein Problem darstelen kann, wenn man sie außerhalb des main thread benutzt. Beispiele befinden sich im Script.

Warum ist es sinnvoll den seed zu setzen bei Random?
Wenn man in mehreren Fällen, die gleiche Folge an Zufallszahlen benötigt ist es nur möglich, wenn man den gleichen Seed setzt.

Was macht Random.Range?
Random.Range gibt ein Intervall an, in dem sich die Zufallszahl befinden muss.
