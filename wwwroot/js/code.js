﻿$(() => {
    setTimeout(() => {
        $(".s-0").fadeIn(500, () => {
            $(".s-1").fadeIn(500, () => {
                $(".s-2").fadeIn(500, () => {
                    $(".s-3").fadeIn(500, () => {
                        $(".s-4").fadeIn(500, () => {
                            $(".s-5").fadeIn(500, () => {
                                $(".s-6").fadeIn(500, () => {
                                    $("#c-container").fadeIn(500)
                                })
                            })
                        })
                    })
                })
            })
        })
    }, 300);
})
