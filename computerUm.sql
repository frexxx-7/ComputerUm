-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1:3306
-- Время создания: Ноя 10 2023 г., 16:40
-- Версия сервера: 5.6.51
-- Версия PHP: 7.2.34

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `computerUm`
--

-- --------------------------------------------------------

--
-- Структура таблицы `components`
--

CREATE TABLE `components` (
  `id` int(11) NOT NULL,
  `name` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `serialNumber` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `idState` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Структура таблицы `computers`
--

CREATE TABLE `computers` (
  `id` int(11) NOT NULL,
  `idModel` int(11) DEFAULT NULL,
  `dateOfPurchase` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `idOperatingSystem` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Дамп данных таблицы `computers`
--

INSERT INTO `computers` (`id`, `idModel`, `dateOfPurchase`, `idOperatingSystem`) VALUES
(1, 3, '11.11.2023', 1),
(3, 3, '10.11.2023', 1),
(4, 1, '01.11.2023', 1);

-- --------------------------------------------------------

--
-- Структура таблицы `models`
--

CREATE TABLE `models` (
  `id` int(11) NOT NULL,
  `name` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Дамп данных таблицы `models`
--

INSERT INTO `models` (`id`, `name`) VALUES
(1, 'qwe'),
(2, 'qwe'),
(3, 'Ноутбук');

-- --------------------------------------------------------

--
-- Структура таблицы `operatingSystem`
--

CREATE TABLE `operatingSystem` (
  `id` int(11) NOT NULL,
  `name` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Дамп данных таблицы `operatingSystem`
--

INSERT INTO `operatingSystem` (`id`, `name`) VALUES
(1, 'asd'),
(2, 'asd 2');

-- --------------------------------------------------------

--
-- Структура таблицы `state`
--

CREATE TABLE `state` (
  `id` int(11) NOT NULL,
  `name` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Структура таблицы `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `login` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `password` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Дамп данных таблицы `users`
--

INSERT INTO `users` (`id`, `login`, `password`) VALUES
(1, 'qwe', 'qwe');

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `components`
--
ALTER TABLE `components`
  ADD PRIMARY KEY (`id`),
  ADD KEY `idState` (`idState`);

--
-- Индексы таблицы `computers`
--
ALTER TABLE `computers`
  ADD PRIMARY KEY (`id`),
  ADD KEY `idModel` (`idModel`),
  ADD KEY `idOperatingSystem` (`idOperatingSystem`);

--
-- Индексы таблицы `models`
--
ALTER TABLE `models`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `operatingSystem`
--
ALTER TABLE `operatingSystem`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `state`
--
ALTER TABLE `state`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `components`
--
ALTER TABLE `components`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT для таблицы `computers`
--
ALTER TABLE `computers`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT для таблицы `models`
--
ALTER TABLE `models`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT для таблицы `operatingSystem`
--
ALTER TABLE `operatingSystem`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT для таблицы `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `components`
--
ALTER TABLE `components`
  ADD CONSTRAINT `components_ibfk_1` FOREIGN KEY (`idState`) REFERENCES `state` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ограничения внешнего ключа таблицы `computers`
--
ALTER TABLE `computers`
  ADD CONSTRAINT `computers_ibfk_1` FOREIGN KEY (`idModel`) REFERENCES `models` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `computers_ibfk_2` FOREIGN KEY (`idOperatingSystem`) REFERENCES `operatingSystem` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
