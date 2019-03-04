The alert component is used to provide visual feedback to the user. This can be used to provide the user with either confirmation messages that a record has been saved, warning messages that an error occurred, or an information message based on a system event.

<div class="sample">
    <h3>Default </h3>
    <pre><code class="html">&lt;alert message=&quot;@@Model.Message&quot;&gt;&lt;/alert&gt;</code></pre>
</div>

<div class="sample">
    <h3>With Header</h3>
  <pre><code class="html">&lt;alert header=&quot;@@Model.Header&quot; message=&quot;@@Model.Message&quot;&gt;
&lt;/alert&gt;</code></pre>
</div>


<div class="sample">
    <h3>Icon Modes</h3>
      <h4>Code:</h4>
    <pre><code class="html">&lt;alert message=&quot;Payment has been processed.&quot; icon=&quot;success&quot;&gt;
&lt;/alert&gt;
&lt;alert message=&quot;Customer information has been saved.&quot; icon=&quot;info&quot;&gt;
&lt;/alert&gt;
&lt;alert message=&quot;Your account has expired.&quot; icon=&quot;danger&quot;&gt;
&lt;/alert&gt;
&lt;alert message=&quot;Unable to save customer info.&quot; icon=&quot;warning&quot;&gt;
&lt;/alert&gt;</code></pre>
</div>

<div class="sample">
    <h3>Dismissable Alert</h3>
    <pre><code class="html">&lt;alert message=&quot;Click on the  button to send a test email.&quot;
       dismissible=&quot;true&quot;
       icon=&quot;info&quot;&gt;
&lt;/alert&gt;</code></pre>
</div>

<div class="sample">
    <h3>Html Text in Message</h3>
    <pre><code class="html">&lt;alert message=&quot;Click on the &lt;b&gt;Test&lt;/b&gt; button to send a test email.&quot;
       message-as-html=&quot;true&quot;
       icon=&quot;info&quot; dismissible=&quot;true&quot;&gt;
&lt;/alert&gt;</code></pre>
</div>

<div class="sample">
    <h3>No Icon</h3>
    <pre><code class="html">&lt;alert message=&quot;@@Model.Message&quot;&gt; icon=&quot;none&quot; alert-class=&quotinfo&quot&lt;/alert&gt;</code></pre>
</div>