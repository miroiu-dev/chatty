"use client";

import { Button } from "@chatty/components/ui/button";
import { useTheme } from "next-themes";

export default function Home() {
    const { setTheme } = useTheme();

    return (
        <div className='flex flex-col w-fit'>
            <Button onClick={() => setTheme("light")}>Light</Button>
            <Button onClick={() => setTheme("dark")}>Dark</Button>
            <Button onClick={() => setTheme("system")}>System</Button>
        </div>
    );
}
