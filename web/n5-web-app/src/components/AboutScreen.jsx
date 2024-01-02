import React from 'react'

export const AboutScreen = () => {
  return (
    <>
      <section className="vh-100" style={{ backgroundColor: '#eee;' }}>
        <div className="container py-5 h-100">
          <div className="row d-flex align-items-center h-100">
            <div className="col col-lg-6 mb-4 mb-lg-0">
              <figure className="bg-white p-3 rounded" style={{ borderLeft: '.25rem solid #a34e78;' }}>
                <blockquote className="blockquote pb-2">
                <p>
                  Buenas! Soy Facu, y este es mi challenge técnico para N5.
                </p>
                <h4>Configs iniciales</h4>
                El proyecto cuenta con tres carpetas:
                <ol>
                  <li>Api</li>
                  <li>Configs</li>
                  <li>Web</li>
                </ol>
                <h5>Base de datos</h5>
                <p>En la folder config está el script que crea la base de datos y las tablas.</p>
                <h5>Puertos</h5>
                <p>
                  La app de React me corre local en el puerto 5173, por lo que tuve que habilitar CORS en el back para que
                  admita request de ese puerto.
                  Las urls, para pegarle a las apis, están hardcode en su respectivo file en la carpeta helpers en el front.
                </p>
                <h5>Desarrollo</h5>
                <p>
                  El proyecto lo codié todo el finde (como podrán ver en el git history), por falta de tiempo no llegué a
                  hacer testing sobre los services, pero está todo creado con interfaces de forma que resulte fácil el mismo.

                  El tema de elasticsearch index desconocía el concepto totalmente, por lo que me decanté por obviarlo a fines
                  no trabarme, y tener un MVP. Con el pattern UnitOfWork tampoco lo conocía, pero lo entendí el tema de consistencia
                  es algo usual en mi trabajo actual, solo que lo hacemos con NHibernate; por ende, entendía el fin y pude
                  implementarlo.
                </p>
                <h5>Axios</h5>
                <p>
                  Al desconocer axios, me decidí por usar fetch para tener una versión funcional con los conceptos que sí
                  estoy familiarizado.
                </p>

                <h4>Conclusión</h4>
                <p>En fin, este es mi challenge, seguramente lo puedo pulir mejor con validaciones de inputs, cubrir escenarios
                  tales como que pasa si la api no responde, si está caída, poner un label con los errores, testing, etc; pero
                  la verdad con el tiempo intesivo que le dediqué y dado que se me acaba el tiempo para entregarlo realmente
                  quedo muy conforme con el resultado.</p>
                </blockquote>
                <figcaption className="blockquote-footer mb-0 font-italic">
                  Gracias por la oportunidad N5!
                </figcaption>
                <p><strong>Facundo</strong></p>
              </figure>
            </div>
          </div>
        </div>
      </section>
    </>
  )
}
