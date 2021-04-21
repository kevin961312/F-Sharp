module TortoiseRacing
let race v1 v2 g =
    if v1 >= v2 then 
      None
    else 
      let seconds = g*(3600)/(v2-v1)
      Some [seconds/3600; (seconds % 3600) / 60; seconds % 60]

race 850 850 70