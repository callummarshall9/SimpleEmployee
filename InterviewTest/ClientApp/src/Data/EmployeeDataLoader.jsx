import React, { useEffect, useState } from 'react';
import * as ReactDOM from "react-dom";
import { toODataString } from "@progress/kendo-data-query";

export const EmployeesDataLoader = (props) => {
    const [loaded, setLoaded] = useState("");

    useEffect(() => {
        async function getData(dataState) {
            const baseUrl = "api/Employees?$count=true&";

            const init = {
                method: "GET",
                accept: "application/json",
                headers: {},
            };

            setLoaded(false);

            var odataResponse = await fetch(baseUrl + toODataString(dataState), init);
            var jsonData = await odataResponse.json();

            setLoaded(true);

            props.onDataReceived.call(undefined, {
                data: jsonData.value,
                total: jsonData.hasOwnProperty("@odata.count") ? jsonData["@odata.count"] : 0,
            });
        }

        getData(props.dataState);
    }, [props.dataState]);

    return !loaded
        ? <LoadingPanel />
        : null;
};

const LoadingPanel = () => {
  const loadingPanel = (
    <div className="k-loading-mask">
      <span className="k-loading-text">Loading</span>
      <div className="k-loading-image" />
      <div className="k-loading-color" />
    </div>
    );

  const gridContent = document && document.querySelector(".k-grid-content");
  return gridContent
    ? ReactDOM.createPortal(loadingPanel, gridContent)
    : loadingPanel;
};